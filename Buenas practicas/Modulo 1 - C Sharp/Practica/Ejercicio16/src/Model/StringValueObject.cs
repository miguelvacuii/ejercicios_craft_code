namespace App.Model
{
    public abstract class StringValueObject
    {
        protected string value;

        public string GetValue()
        {
            return value;
        }

        public bool Equals(StringValueObject valueObject)
        {
            if (this.GetValue().Equals(valueObject.GetValue())) {
                return true;
            }

            return false;
        }
    }
}
