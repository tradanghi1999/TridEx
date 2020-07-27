using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public interface TestCaseIGUI
    {
        void beginTesting(string testContent);
        void attachResult(string res);
        void endTesting();
    }
}
