﻿using System.Collections.Generic;
using Pizza.Contracts.Presentation.Operations.Requests.Configuration;

namespace Pizza.Mvc.Grid.Metamodel
{
    public class FilterMetamodel
    {
        public FilterOperator Operator { get; private set; }
        public Dictionary<string, string> SelectFilterMap { get; private set; }

        public FilterMetamodel(FilterOperator @operator, Dictionary<string, string> selectFilterMap)
        {
            this.Operator = @operator;
            this.SelectFilterMap = selectFilterMap;
        }
    }
}