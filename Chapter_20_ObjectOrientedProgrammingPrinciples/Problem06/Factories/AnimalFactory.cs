using System;

namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Factories
{
    using Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    class AnimalFactory : IAnimalFactory
    {
        public IAnimal Create(Type type, params string[] args)
        {

            //Get all constructors
            ConstructorInfo[] allTypeConstructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

            //Get required constructor
            ConstructorInfo constructor = allTypeConstructors.FirstOrDefault(c => c.GetParameters().Count() == args.Length);

            if (constructor==null)
            {
                throw new ArgumentException("Invalid count of parameters");
            }

            //Get constructor parameters
            var parameters = constructor.GetParameters().ToArray();

            //Container to invoke a constructor
            var convertedParameters = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                var parameterValueAsString = args[i];

                var parameter = parameters[i];

                var parameterType = parameter.ParameterType;

                //Converted type of parameter
                object value = null;

                value = ConvertStringValueToRequiredType(parameterValueAsString, parameterType);

                //Add to container
                convertedParameters[i] = value;
            }

            IAnimal animal = (IAnimal)Activator.CreateInstance(type, convertedParameters);

            return animal;
        }

        private static object ConvertStringValueToRequiredType(string parameterValueAsString, Type parameterType)
        {
            object value;

            if (parameterType.BaseType == typeof(Enum))
            {
                value = Enum.Parse(parameterType, parameterValueAsString);
            }
            else
            {
                value = Convert.ChangeType(parameterValueAsString, parameterType, CultureInfo.InvariantCulture);
            }

            return value;
        }
    }
}
