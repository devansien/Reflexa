namespace Reflexa
{
    public class StateMap
    {
        public int NumPlayed { get; set; }

        public static StateMap GetDefaultState()
        {
            StateMap defaultState = new StateMap()
            {
                NumPlayed = 1
            };

            return defaultState;
        }
    }
}
