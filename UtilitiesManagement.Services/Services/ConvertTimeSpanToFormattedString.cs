namespace  UtilitiesManagement.Services.Services
{
    public static class ConvertTimeSpanToFormattedString
    {
        public static AuthRemainingTimeForUserResponse ToReadableAsObject(this TimeSpan span, bool isDeleted, DateTime endDate)
        {
            var obj = new AuthRemainingTimeForUserResponse();
            _ = string.Format("{0}{1}{2}{3}",
                span.Duration().Days > 0 ? string.Format("{0:0} day{1}, ", obj.Days = span.Days, (obj.Days = span.Days) == 1 ? string.Empty : "s") : string.Empty,
                span.Duration().Hours > 0 ? string.Format("{0:0} hour{1}, ", obj.Hours = span.Hours, (obj.Hours = span.Hours) == 1 ? string.Empty : "s") : string.Empty,
                span.Duration().Minutes > 0 ? string.Format("{0:0} minute{1}, ", obj.Minutes = span.Minutes, (obj.Minutes = span.Minutes) == 1 ? string.Empty : "s") : string.Empty,
                span.Duration().Seconds > 0 ? string.Format("{0:0} second{1}, ", obj.Seconds = span.Seconds, (obj.Seconds = span.Seconds) == 1 ? string.Empty : "s") : string.Empty);
            bool isDateTimeAway = DateTime.UtcNow.AddHours(2) > endDate;
            return new AuthRemainingTimeForUserResponse()
            {
                Days = obj.Days > 0 && !isDeleted && !isDateTimeAway ? obj.Days : 0,
                Hours = obj.Hours > 0  && !isDeleted && !isDateTimeAway ? obj.Hours : 0,
                Minutes = obj.Minutes > 0 && !isDeleted && !isDateTimeAway ? obj.Minutes : 0,
                Seconds = obj.Seconds > 0 && !isDeleted && !isDateTimeAway ? obj.Seconds : 0
            };
        }

        public static string ToReadableString(this TimeSpan span)
        {
            string formatted = string.Format("{0}{1}{2}{3}",
                span.Duration().Days > 0 ? string.Format("{0:0} day{1}, ", span.Days, span.Days == 1 ? string.Empty : "s") : string.Empty,
                span.Duration().Hours > 0 ? string.Format("{0:0} hour{1}, ", span.Hours, span.Hours == 1 ? string.Empty : "s") : string.Empty,
                span.Duration().Minutes > 0 ? string.Format("{0:0} minute{1}, ", span.Minutes, span.Minutes == 1 ? string.Empty : "s") : string.Empty,
                span.Duration().Seconds > 0 ? string.Format("{0:0} second{1}", span.Seconds, span.Seconds == 1 ? string.Empty : "s") : string.Empty);

            if (formatted.EndsWith(", ")) formatted = formatted.Substring(0, formatted.Length - 2);

            if (string.IsNullOrEmpty(formatted)) formatted = "0 seconds";

            //var da = Convert.ToDateTime(formatted);
            return formatted;
        }
    }
}
