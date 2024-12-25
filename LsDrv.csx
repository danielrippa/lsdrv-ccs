//cs_winapp

using System.IO;
using System.Linq;

class Program {

  static string Quotes(string input) {
    return $"\"{input}\"";
  }

  static void Main(string[] args) {

    try {

      var drives = DriveInfo.GetDrives();

      foreach (var drive in drives) {

        var driveName = drive.Name;
        var volumeName = drive.VolumeLabel ?? "";

        var matchesFilter = args.Length == 0 || args.Any(arg => volumeName.IndexOf(arg, StringComparison.OrdinalIgnoreCase) >= 0);

        if (matchesFilter) {

          Console.WriteLine($"{ Quotes(driveName) } { Quotes(volumeName) }");

        }

      }

    } catch (Exception e) {

      Console.Error.WriteLine($"Error: {e.Message}");
      Environment.Exit(1);
    }

  }

}

