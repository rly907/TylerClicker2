namespace TylerClicker2
{
    public static class GlobalVariables
    {
        private static int sharedVariable;
        public static int SharedVariable
        {
            get => sharedVariable;
            set
            {
                sharedVariable = value;
                OnVariableUpdated?.Invoke(null, sharedVariable);
            }
        }

        public static event EventHandler<int> OnVariableUpdated;
    }
}
