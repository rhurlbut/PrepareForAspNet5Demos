using System;
using Microsoft.AspNet.Mvc;

namespace ASPNET5_SampleMvc.Compiler.Preprocess
{
    public class RazorPreCompilation : RazorPreCompileModule
    {
        public RazorPreCompilation(IServiceProvider provider) : base(provider)
        {
        }
    }
}
