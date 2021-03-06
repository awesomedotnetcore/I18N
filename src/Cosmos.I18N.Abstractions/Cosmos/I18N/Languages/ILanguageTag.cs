using System.Globalization;

namespace Cosmos.I18N.Languages {
    /// <summary>
    /// Interface for language tag
    /// </summary>
    public interface ILanguageTag {
        /// <summary>
        /// Returns the mandatory 2 character language subtag.
        /// </summary>
        /// <returns>A string describing a language subtag, or null if no such subtag present (indicating a null or error instance).</returns>
        string GetLanguage();

        /// <summary>
        /// Returns a full language tag
        /// </summary>
        /// <returns>A string describing the full language tag or "" if null or error instance.</returns>
        string ToString();

        /// <summary>
        /// Returns the optional 3 character extlang subtag.
        /// </summary>
        /// <returns>A string describing a extlang subtag, or null if no such subtag present.</returns>
        string GetExtlang();

        /// <summary>
        /// Returns the optional 4 character script subtag.
        /// </summary>
        /// <returns>A string describing a script subtag, or null if no such subtag present.</returns>
        string GetScript();

        /// <summary>
        /// Returns the optional 2 or 3 character region subtag.
        /// </summary>
        /// <returns>A string describing a region subtag, or null if no such subtag present.</returns>
        string GetRegion();

        /// <summary>
        /// Returns zero or more optional variant subtags.
        /// </summary>
        /// <returns>An array of strings describing the variant subtags, or null if no such subtag present.</returns>
        string[] GetVariant();

        /// <summary>
        /// Returns the optional extension subtag.
        /// </summary>
        /// <returns>A string describing an extension subtag, or null if no such subtag present.</returns>
        string GetExtension();

        /// <summary>
        /// Returns the optional privateuse subtag.
        /// </summary>
        /// <returns>A string describing a privateuse subtag, or null if no such subtag present.</returns>
        string GetPrivateuse();

        /// <summary>
        /// Returns an object representing any logical parent of the tag.
        /// </summary>
        /// <returns>Parent object or null if no parent.</returns>
        ILanguageTag GetParent();

        /// <summary>
        /// Returns the maximum number of parents possible.
        /// This is really a static value provided by the underlying impl.
        /// </summary>
        int GetMaxParents();

        /// <summary>
        /// Corresponding CultureInfo instance, or null if the langtag is unsupported on this system.
        /// </summary>
        CultureInfo GetCultureInfo();

        /// <summary>
        /// If the system supports a cultureinfo object for the language, this is the native name of 
        /// the language suitable for user display, otherwise it is the language tag string.
        /// </summary>
        string GetNativeNameTitleCase();

        /// <summary>
        /// Gets alias of this LanguageTag
        /// </summary>
        string Alias { get; }

        /// <summary>
        /// Update this LanguageTag's alias
        /// </summary>
        /// <param name="alias"></param>
        void UpdateAlias(string alias);
    }
}