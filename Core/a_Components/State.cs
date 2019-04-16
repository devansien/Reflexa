using Amazon.DynamoDBv2.DataModel;

namespace Reflexa
{
    [DynamoDBTable(SessionKey.DbTableName)]
    class State
    {
        [DynamoDBHashKey]
        public string UserId { get; set; }
        public StateMap UserState { get; set; }
    }
}
