using System.Threading;
using System.Threading.Tasks;
using MirrorSharp.Advanced;
using SharpLab.Server.Common;

namespace SharpLab.Server.Execution {
    public interface IContainerExecutor {
        Task<string> ExecuteAsync(CompilationStreamPair streams, IWorkSession session, CancellationToken cancellationToken);
    }
}
