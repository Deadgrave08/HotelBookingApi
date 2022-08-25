using System;
using AboutUsApi.Controllers;
using AboutUsApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace AboutUsTest
{
    public class AboutUsProjectTest
    {
        private AboutUs _aboutUs = null;
        public AboutUsProjectTest()
        {
            if (_aboutUs == null)
            {
                _aboutUs = new AboutUs();
            }
        }
        [Fact]
        public void TestGet()
        {

        }
        public async void TestAdd()
        {
            AboutUsController
            string name = "Mohd Arif";
            string bio = "Web Developer";
            string profilePicture = "https://thumbs.dreamstime.com/b/handsome-male-model-posing-elegant-smile-88528667.jpg";

            var expected_value =
            Assert.Equal(expected_value, actual_value);
        }
    }
}
