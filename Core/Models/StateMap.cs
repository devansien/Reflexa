using System.Collections.Generic;

namespace Reflexa
{
    class StateMap
    {
        public int NumPlayed { get; set; }
        public List<Sentence> Sentences { get; set; }


        public static StateMap GetDefaultState()
        {
            StateMap defaultState = new StateMap()
            {
                NumPlayed = 1,
                Sentences = new List<Sentence>()
            };

            return defaultState;
        }
    }
}
