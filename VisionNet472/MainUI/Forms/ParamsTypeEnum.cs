using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Forms
{
    public enum ParamsTypeEnum
    {
        Time=1,
        SerialNum,
        Feature,
        FullMatch

    }

    public static class RuleParamsType
    {
        public const  string Time = "Time";

        public const string SerialNum = "SerialNum";

        public const string Feature = "Feature";

        public const string FullMatch = "FullMatch";

    }

    public static class ParamsDateFormatType
    {
        public const string yyyyMMdd = "yyyyMMdd";

        public const string yyMMdd = "yyMMdd";


    }

    public static class ParamsFeatureFormatType
    {
        public const string Pre = "Pre";

        public const string Suffix = "Suffix";

        public const string Contain = "Contain";


    }
}
