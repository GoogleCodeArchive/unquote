# Assumptions #

The latest revision in trunk is ready for release and all unit tests pass.

# Build #

  1. `svn checkout` the head revision from [trunk](https://unquote.googlecode.com/svn/trunk)
  1. Update version numbers (`<monumental>.<significant>.<minor or bug fix>`) and commit changes to trunk
    * `AssemblyVersion` and `AssemblyFileVersion` in `\Unquote\AssemblyInfo.fs` and `\Unquote.Silverlight\AssemblyInfo.fs`
  1. Run build.bat
    1. Enter the version number when prompted
    1. Check output for any errors
    1. The NuGet package and Downloads zip will be located at `\builds\Unquote-<version>\Unquote.<version>.nupkg` and `\builds\Unquote-<version>\Unquote-<version>.zip` respectively
  1. Perform quality assurance
    * Deploy `Unquote.<version>.nupkg` to a local NuGet repository and insure everything works properly through the VS 2010 and VS 11 NuGet Package Managers
    * Unzip and test binaries in `Unquote-<version>.zip` for both F# interactive and normal F# projects.

# Release #
  * Update the milestone for all issues which are being included in the release to the proper version number
    1. Search within `All issues` for `-has:milestone status:fixed`
    1. Click `Select: All` to select all of them
    1. Choose "Bulk edit" action from the "Actions..." drop-down list
    1. Add the label `Milestone-Release<version number>`
    1. Click "Update ## Issues" button to save
  * Update the ReleaseNotes
    1. Search within `All issues` for `milestone:Release<version>`
    1. Click the "CSV" link in the bottom right-hand corner of the issue list to export the issues to a csv file
    1. Open the csv file in Excel
    1. Delete all columns except for the ID and Summary columns from the csv
    1. Open up the ReleaseNotes wiki page for edit
    1. Copy and paste the records from the csv into the ReleaseNotes following the existing formatting conventions and save
  * Upload zip to Downloads (now hosted by Swensen Software)
    1. TODO
  * Publish the NuGet package
    1. Go to https://nuget.org/packages/upload and follow instructions.

# Finalize #

Tag the head revision of the trunk with the name `<version number>`.

# Process Improvement #

The following issues have been created for improving the build and release process
  * [Issue 74](https://code.google.com/p/unquote/issues/detail?id=74)
  * [Issue 75](https://code.google.com/p/unquote/issues/detail?id=75)

Other ideas
  * Consider [scripting the Downloads upload](http://code.google.com/p/support/wiki/ScriptedUploads)
  * Script NuGet package publication.