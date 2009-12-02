// This file is part of the OWASP O2 Platform (http://www.owasp.org/index.php/OWASP_O2_Platform) and is released under the Apache 2.0 License (http://www.apache.org/licenses/LICENSE-2.0)
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace O2.Kernel.Interfaces.XRules
{
    public interface ILoadedXRule
    {
        IXRule XRule { get; set; }
        string Source { get; set; }
        Dictionary<XRuleAttribute, MethodInfo> methods { get; set; }
    }

    public class KLoadedXRule : ILoadedXRule
    {
        public IXRule XRule { get; set; }
        public string Source { get; set; }

        public Dictionary<XRuleAttribute, MethodInfo> methods { get; set; }

        public KLoadedXRule(IXRule xRule, string source)
        {
            XRule = xRule;
            Source = source;
            methods = new Dictionary<XRuleAttribute, MethodInfo>();
            foreach (var method in DI.reflection.getMethods(XRule.GetType()))
            {
                var attribute = (XRuleAttribute)DI.reflection.getAttribute(method, typeof(XRuleAttribute));
                if (attribute != null && false == methods.ContainsKey(attribute))
                    methods.Add(attribute, method);
            }
        }

        public override string ToString()
        {
            var toString = (XRule != null) ? (XRule.Name ?? "") : "";
            toString += (string.IsNullOrEmpty(Source)) ? "" : "    (" + Source + ")";
            return toString;
        }
    }

}
