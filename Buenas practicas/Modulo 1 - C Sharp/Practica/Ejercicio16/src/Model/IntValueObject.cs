namespace App.Model
{
    public abstract class IntValueObject
    {
        protected int value;

        public int GetValue()
        {
            return value;
        }

        public bool Equals(IntValueObject valueObject)
        {
            if (this.GetValue().Equals(valueObject.GetValue())) {
                return true;
            }

            return false;
        }
    }
}
