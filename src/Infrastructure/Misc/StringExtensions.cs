﻿namespace Infrastructure.Misc;

public static class StringExtensions
{
    public static bool EqualsIgnoreCase(this string? s1, string? s2)
    {
        return s1 is not null && s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
    }

    public static string ToReadableString(this IEnumerable<string> separatedStrings, string separator = ", ")
    {
        return String.Join(separator, separatedStrings);
    }
}