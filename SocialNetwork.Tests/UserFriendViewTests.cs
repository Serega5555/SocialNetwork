using SocialNetwork.PLL.Views;
using SocialNetwork.BLL.Models;
using System.Runtime.CompilerServices;

namespace SocialNetwork.Tests;

[TestFixture]
public class UserFriendViewTests
{
    private UserFriendView _userFriendView = new UserFriendView();

    [Test]
    public void Show_DisplaysNoFriendsMessage_WhenFriendsListIsEmpty()
    {
        // Arrange
        var friends = new List<User>();  // Ïåðåäàåì ïóñòîé ñïèñîê äðóçåé
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Act
            _userFriendView.Show(friends);

            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual("Ìîè äðóçüÿ\r\nÓ âàñ íåò äðóçåé", result);
        }
    }
}
