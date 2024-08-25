using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class FeatureGetReqStepDefinitions
    {
        private readonly ISpecFlowOutputHelper _outputHelper;
        HttpClient _httpClient;
        HttpResponseMessage _response;
        private string _responseBody;

        public FeatureGetReqStepDefinitions(ISpecFlowOutputHelper outputHelper)
        {
            _httpClient = new HttpClient();
            _outputHelper = outputHelper;
        }

        [Given(@"the user send a get request with url as ""([^""]*)""")]
        public async Task GivenTheUserSendAGetRequestWithUrlAs(string uri)
        {
            _response = await _httpClient.GetAsync(uri);
            _response.EnsureSuccessStatusCode();
            _responseBody = await _response.Content.ReadAsStringAsync(); 
            _outputHelper.WriteLine(_responseBody);
        }

        [Then(@"request shold be success with (.*)s codes")]
        public void ThenRequestSholdBeSuccessWithSCodes(int expectedStatusCode)
        {
            Assert.True(_response.IsSuccessStatusCode);
            //Assert.Equal(expectedStatusCode, (int)_response.StatusCode);
        }
    }
}
