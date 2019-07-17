using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Client

{
   
    public enum PureCloudRegionHosts {
        [Description("https://api.mypurecloud.com")]
        us_east_1,
        [Description("https://api.mypurecloud.ie")]
        eu_west_1,
        [Description("https://api.mypurecloud.de")]
        eu_central_1,
        [Description("https://api.mypurecloud.jp")]
        ap_northeast_1,
        [Description("https://api.mypurecloud.com.au")]
        ap_southeast_1

    }

    public static class EnumExtensionMethods
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }

    }
}