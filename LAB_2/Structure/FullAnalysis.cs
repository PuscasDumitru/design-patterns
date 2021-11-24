using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structure
{
     class FullAnalysis : IDiagnostics
     {
          public void AnalyzeSystem()
          {
               Console.WriteLine("Analyzing deeply the whole system");
          }
     }
}
