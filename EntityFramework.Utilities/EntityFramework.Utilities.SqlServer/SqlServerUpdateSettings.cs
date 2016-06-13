﻿namespace EntityFramework.Utilities.SqlServer
{
    public class SqlServerUpdateSettings
    {
        public SqlServerUpdateSettings()
        {
            Analyzer = new SqlQueryAnalyzer();
            SqlGenerator = new SqlServerTSQLGenerator();
        }

        public SqlQueryAnalyzer Analyzer { get; private set; }
        public SqlServerTSQLGenerator SqlGenerator { get; private set; }
    }
}
