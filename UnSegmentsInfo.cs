using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace UnSegments
{
  public class UnSegmentsInfo : GH_AssemblyInfo
  {
    public override string Name => "UnSegments";

    //Return a 24x24 pixel bitmap to represent this GHA library.
    public override Bitmap Icon => null;

    //Return a short string describing the purpose of this GHA library.
    public override string Description => "";

    public override Guid Id => new Guid("80204e56-04e3-4276-ac26-5e2f8ea324ec");

    //Return a string identifying you or your company.
    public override string AuthorName => "";

    //Return a string representing your preferred contact details.
    public override string AuthorContact => "";

    //Return a string representing the version.  This returns the same version as the assembly.
    public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
  }
}