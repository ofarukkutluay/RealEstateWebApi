

using NpgsqlTypes;
using Serilog.Events;
using Serilog.Sinks.PostgreSQL;

namespace RealEstateWebApi.WebApi.Configurations.ColumWriters
{
    public class UserIdColumnWriter : ColumnWriterBase
    {
        public UserIdColumnWriter() : base(NpgsqlDbType.Varchar)
        {
        }

        public override object GetValue(LogEvent logEvent, IFormatProvider formatProvider = null)
        {
            var (useremail, value) = logEvent.Properties.FirstOrDefault(p => p.Key == "user_id");
            return value?.ToString() ?? null;
        }
    }
}
