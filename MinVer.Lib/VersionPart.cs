namespace MinVer.Lib;

public enum VersionPart
{
    Patch = 0,
    Minor = 1,
    Major = 2,
    Disable = 3,
}

public static class VersionPartExtensions
{
    public static string ValidValues => "major, minor, patch (default) or disable";
}
