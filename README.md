This should deployed in server like app service and then Url: https:{appservice_domainname}/mcp added in MCP Client (VS code Chat, etc) 
or you can also create your own MCP server amd load tool


{
	"servers": {
		"CalculatorMcpServer": {
			"url": "https://calcculatormcpserver-cjbqe0atbma3b8aw.westus3-01.azurewebsites.net/mcp",
			"type": "http"
		}
	},
	"inputs": []
}
