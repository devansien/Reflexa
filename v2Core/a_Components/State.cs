using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;

namespace Reflexa
{
    [DynamoDBTable(SessionKey.DbTableName)]
    public class State
    {
        [DynamoDBHashKey]
        public string UserId { get; set; }
        public StateMap UserState { get; set; }
        public List<Utterance> Utterances { get; set; }
    }
}
