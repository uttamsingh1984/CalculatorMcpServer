using ModelContextProtocol.Server;
using System.ComponentModel;

namespace CalculatorMcpServer
{
    [McpServerToolType]
    public class CalculatorTools
    {

        [McpServerTool(Name ="Add")]
        [Description("Returns the result of addition of given 2 numbers.")]
        public static int Addition(ILogger<McpServer> _logger, int a, int b)
        {
            _logger.LogWarning($"Addition called a={a} and b={b}");
            return a + b;
        }

        [McpServerTool(Name ="Substraction")]
        [Description("Returns the result of substraction of given 2 numbers.")]
        public static int Substraction(ILogger<McpServer> _logger, int a, int b)
        {
            _logger.LogWarning($"Substraction called a={a} and b={b}");
            return (a - b);
        }

        [McpServerTool(Name ="Multiply")]
        [Description("Returns the result of multiply of given 2 numbers.")]
        public static int Multiply(ILogger<McpServer> _logger, int a, int b)
        {
            _logger.LogWarning($"Multiply called a={a} and b={b}");
            return a * b;
        }
    }
}
