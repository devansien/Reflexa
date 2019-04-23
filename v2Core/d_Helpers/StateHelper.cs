using System.Collections.Generic;

namespace Reflexa
{
    class StateHelper
    {
        public static State ValidateState(string userId, State save)
        {
            if (save == null)
            {
                save = new State() { UserId = userId };
                save.UserState = StateMap.GetDefaultState();
                save.Utterances = new List<Utterance>();
            }

            if (save.Utterances == null)
                save.Utterances = new List<Utterance>();

            return save;
        }
    }
}
