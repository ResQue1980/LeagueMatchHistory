using LeagueMatchHistory.MatchHistory.Games.Timeline;
using LeagueMatchHistory.MatchHistory.Games.Timeline.Frames;
using LeagueMatchHistory.MatchHistory.Games.Timeline.Frames.Events;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace LeagueMatchHistory.MatchHistory
{
    public class CustomObjectConverter : JavaScriptConverter
    {
        private static readonly Type[] _supportedTypes = new[] { typeof(TimelineDelta), typeof(ParticipantFrames), typeof(EventFrame) };

        public override IEnumerable<Type> SupportedTypes { get { return _supportedTypes; } }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            if (type == typeof(TimelineDelta))
            {
                var obj = new TimelineDelta();
                if (dictionary.ContainsKey("0-10"))
                    obj.StartToTen = serializer.ConvertToType<float>(dictionary["0-10"]);
                if (dictionary.ContainsKey("10-20"))
                    obj.TenToTwenty = serializer.ConvertToType<float>(dictionary["10-20"]);
                if (dictionary.ContainsKey("20-30"))
                    obj.TwentyToThirty = serializer.ConvertToType<float>(dictionary["20-30"]);
                if (dictionary.ContainsKey("30-end"))
                    obj.ThirtyToEnd = serializer.ConvertToType<float>(dictionary["30-end"]);
                return obj;
            }

            if (type == typeof(ParticipantFrames))
            {
                var obj = new ParticipantFrames();
                if (dictionary.ContainsKey("1"))
                    obj.one = serializer.ConvertToType<ParticipantFrame>(dictionary["1"]);
                if (dictionary.ContainsKey("2"))
                    obj.two = serializer.ConvertToType<ParticipantFrame>(dictionary["2"]);
                if (dictionary.ContainsKey("3"))
                    obj.three = serializer.ConvertToType<ParticipantFrame>(dictionary["3"]);
                if (dictionary.ContainsKey("4"))
                    obj.four = serializer.ConvertToType<ParticipantFrame>(dictionary["4"]);
                if (dictionary.ContainsKey("5"))
                    obj.five = serializer.ConvertToType<ParticipantFrame>(dictionary["5"]);
                if (dictionary.ContainsKey("6"))
                    obj.six = serializer.ConvertToType<ParticipantFrame>(dictionary["6"]);
                if (dictionary.ContainsKey("7"))
                    obj.seven = serializer.ConvertToType<ParticipantFrame>(dictionary["7"]);
                if (dictionary.ContainsKey("8"))
                    obj.eight = serializer.ConvertToType<ParticipantFrame>(dictionary["8"]);
                if (dictionary.ContainsKey("9"))
                    obj.nine = serializer.ConvertToType<ParticipantFrame>(dictionary["9"]);
                if (dictionary.ContainsKey("10"))
                    obj.ten = serializer.ConvertToType<ParticipantFrame>(dictionary["10"]);
                return obj;
            }

            if (type == typeof(EventFrame))
            {
                var obj = new EventFrame();
                if (dictionary.ContainsKey("type"))
                {
                    if ("WARD_PLACED" == (string)dictionary["type"])
                    {
                        return GetTypeFromDictionary<WardPlacedFrame>(dictionary, serializer);
                    }
                    else if ("WARD_KILL" == (string)dictionary["type"])
                    {
                        return GetTypeFromDictionary<WardKillFrame>(dictionary, serializer);
                    }
                    else if ("ELITE_MONSTER_KILL" == (string)dictionary["type"])
                    {
                        return GetTypeFromDictionary<EliteMonsterKillFrame>(dictionary, serializer);
                    }
                    else if ("CHAMPION_KILL" == (string)dictionary["type"])
                    {
                        return GetTypeFromDictionary<ChampionKillFrame>(dictionary, serializer);
                    }
                    else if ("BUILDING_KILL" == (string)dictionary["type"])
                    {
                        return GetTypeFromDictionary<BuildingKillFrame>(dictionary, serializer);
                    }
                }

                //Unknown type?
                return obj;
            }

            return null;
        }

        public T GetTypeFromDictionary<T>(IDictionary<string, object> dict, JavaScriptSerializer serializer)
        {
            T type = (T)Activator.CreateInstance(typeof(T));
            foreach (KeyValuePair<string, object> pair in dict)
            {
                var f = typeof(T).GetField(pair.Key);
                Type p = f.FieldType;
                f.SetValue(type, serializer.ConvertToType(pair.Value, p));
            }

            return type;
        }

        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            var timeDelta = obj as TimelineDelta;
            if (timeDelta != null)
            {
                return new Dictionary<string, object>
                {
                    {"0-10", timeDelta.StartToTen },
                    {"10-20", timeDelta.TenToTwenty },
                    {"20-30", timeDelta.TwentyToThirty },
                    {"30-end", timeDelta.ThirtyToEnd }
                };
            }

            var partFrames = obj as ParticipantFrames;
            if (partFrames != null)
            {
                return new Dictionary<string, object>
                {
                    {"1", partFrames.one },
                    {"2", partFrames.two },
                    {"3", partFrames.three },
                    {"4", partFrames.four },
                    {"5", partFrames.five },
                    {"6", partFrames.six },
                    {"7", partFrames.seven },
                    {"8", partFrames.eight },
                    {"9", partFrames.nine },
                    {"10", partFrames.ten }
                };
            }
            return new Dictionary<string, object>();
        }
    }
}
