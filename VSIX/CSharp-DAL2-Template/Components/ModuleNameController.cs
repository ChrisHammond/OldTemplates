/*
' Copyright (c) $year$ $ownername$
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/
using System.Collections.Generic;
using DotNetNuke.Data;

namespace $rootnamespace$$safeprojectname$.Components
{
    class $safeprojectname$Controller
   { 
                public void Create$safeprojectname$($safeprojectname$ t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<$safeprojectname$>();
                rep.Insert(t);
            }
        }

        public void Delete$safeprojectname$(int itemId, int moduleId)
        {
            var t = Get$safeprojectname$(itemId,moduleId);
            Delete$safeprojectname$(t);
        }

        public void Delete$safeprojectname$($safeprojectname$ t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<$safeprojectname$>();
                rep.Delete(t);
            }
        }

        public IEnumerable<$safeprojectname$> Get$safeprojectname$s(int moduleId)
        {
            IEnumerable<$safeprojectname$> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<$safeprojectname$>();
                t = rep.Get(moduleId);
            }
            return t;
        }

        public $safeprojectname$ Get$safeprojectname$(int itemId, int moduleId)
        {
            $safeprojectname$ t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<$safeprojectname$>();
                t = rep.GetById(itemId, moduleId);
            }
            return t;
        }

        public void Update$safeprojectname$($safeprojectname$ t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<$safeprojectname$>();
                rep.Update(t);
            }
        }        

    }
}
