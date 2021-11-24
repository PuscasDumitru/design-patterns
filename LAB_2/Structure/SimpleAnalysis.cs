using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structure
{
     class SimpleAnalysis : IDiagnostics
     {
          public void AnalyzeSystem()
          {
               Console.WriteLine("Quick analysis of the system...");
          }
          
     }
}
