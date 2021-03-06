using System;
using System.Collections.Generic;
using SS14.Shared.GameObjects;
using SS14.Shared.Serialization;

namespace Content.Shared.GameObjects.EntitySystemMessages
{
    public static class VerbSystemMessages
    {
        [Serializable, NetSerializable]
        public class RequestVerbsMessage : EntitySystemMessage
        {
            public readonly EntityUid EntityUid;

            public RequestVerbsMessage(EntityUid entityUid)
            {
                EntityUid = entityUid;
            }
        }

        [Serializable, NetSerializable]
        public class VerbsResponseMessage : EntitySystemMessage
        {
            public readonly List<VerbData> Verbs;
            public readonly EntityUid Entity;

            public VerbsResponseMessage(List<VerbData> verbs, EntityUid entity)
            {
                Verbs = verbs;
                Entity = entity;
            }

            [Serializable, NetSerializable]
            public readonly struct VerbData
            {
                public readonly string Text;
                public readonly string Key;
                public readonly bool Available;

                public VerbData(string text, string key, bool available)
                {
                    Text = text;
                    Key = key;
                    Available = available;
                }
            }
        }

        [Serializable, NetSerializable]
        public class UseVerbMessage : EntitySystemMessage
        {
            public readonly EntityUid EntityUid;
            public readonly string VerbKey;

            public UseVerbMessage(EntityUid entityUid, string verbKey)
            {
                EntityUid = entityUid;
                VerbKey = verbKey;
            }
        }

    }
}
