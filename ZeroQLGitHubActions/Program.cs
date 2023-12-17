
var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://localhost:10000/graphql");

var client = new ZeroQL.Client.ZeroQLClient(httpClient);
var response = await client.Query(q => q.Me(m => m.Id));

Console.WriteLine(response.Data);