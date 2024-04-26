using Faker;

namespace TKSRandomFakeEmailGenerator;
public static class EmailGenerator
{
    /// <summary>
    /// <b>Generate:</b> Generates a specified number of random email addresses.
    /// </summary>
    /// <param name="count">The number of email addresses to generate.</param>
    /// <returns>A list of randomly generated email addresses.</returns>
    public static List<string> Generate(int count)
    {
        var emails = new List<string>();

        for (int i = 0; i < count; i++)
        {
            emails.Add(Internet.Email());
        }

        return emails;
    }
}
