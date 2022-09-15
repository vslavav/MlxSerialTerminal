using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlxSerialTerminal
{
    internal class FilterMgr
    {
        private List<string> _filters = new List<string>();

        bool _enabled = false;



        public FilterMgr()
        {
            _enabled = false;
            AddFilter("slava");
        }

        public void SetEnaible(bool bVal)
        { _enabled = bVal; }

        public bool GetEnabled()
        { return _enabled; }


        public string ApplyFilters(string sText)
        {
            string _sOutput = "";
            foreach (var filter in _filters)
            {
                if (sText.ToLower().IndexOf(filter.ToLower()) != -1)
                {
                    _sOutput = sText;
                    break;
                }
            }
            return _sOutput;
        }

        public void AddFilter(string sFilter)
        {
            foreach (string sVal in _filters)
            {
                if (sFilter.ToLower() == sVal.ToLower())
                {
                    return;
                }
            }
            _filters.Add(sFilter);

        }
    }
}
