﻿using System;
using System.Collections.Generic;

namespace PgQuery
{
    /// <summary>
    /// Class of SQL command / query which allows having condition statements
    /// </summary>
    public abstract partial class SqlConditionBuilder : SqlBuilder
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SqlConditionBuilder()
        {
        }

        /// <summary>
        /// Build condition statements
        /// </summary>
        /// <returns>Condition statements, including ordering and limiting</returns>
        public string BuildConditionStatement()
        {
            return this.BuildWhereStatement() + this.BuildOrderStatement() + this.BuildLimitStatement();
        }

        /// <summary>
        /// Set custom parameter
        /// </summary>
        /// <param name="paramName">Parameter name</param>
        /// <param name="value">Value</param>
        /// <returns>self</returns>
        public SqlConditionBuilder SetCustomParameter(string paramName, object value)
        {
            this.ParamBinder.SetCustom(paramName, value);
            return this;
        }
    }
}
