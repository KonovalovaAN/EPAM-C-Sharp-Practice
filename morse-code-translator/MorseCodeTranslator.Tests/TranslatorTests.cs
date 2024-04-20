using System.Text;
using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace MorseCodeTranslator.Tests
{
    [TestFixture]
    public class TranslatorTests
    {
        private static object[] textToMorseMessages =
        {
            new object[] { string.Empty, string.Empty },
            new object[] { "A", ".-" },
            new object[] { "a", ".-" },
            new object[] { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --.." },
            new object[] { "abcdefghijklmnopqrstuvwxyz", ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --.." },
            new object[]
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                ".-.. --- .-. . -- .. .--. ... ..- -- -.. --- .-.. --- .-. ... .. - .- -- . - -.-. --- -. ... . -.-. - . - ..- .-. .- -.. .. .--. .. ... -.-. .. -. --. . .-.. .. - ... . -.. -.. --- . .. ..- ... -- --- -.. - . -- .--. --- .-. .. -. -.-. .. -.. .. -.. ..- -. - ..- - .-.. .- -... --- .-. . . - -.. --- .-.. --- .-. . -- .- --. -. .- .- .-.. .. --.- ..- .- ..- - . -. .. -- .- -.. -- .. -. .. -- ...- . -. .. .- -- --.- ..- .. ... -. --- ... - .-. ..- -.. . -..- . .-. -.-. .. - .- - .. --- -. ..- .-.. .-.. .- -- -.-. --- .-.. .- -... --- .-. .. ... -. .. ... .. ..- - .- .-.. .. --.- ..- .. .--. . -..- . .- -.-. --- -- -- --- -.. --- -.-. --- -. ... . --.- ..- .- - -.. ..- .. ... .- ..- - . .. .-. ..- .-. . -.. --- .-.. --- .-. .. -. .-. . .--. .-. . .... . -. -.. . .-. .. - .. -. ...- --- .-.. ..- .--. - .- - . ...- . .-.. .. - . ... ... . -.-. .. .-.. .-.. ..- -- -.. --- .-.. --- .-. . . ..- ..-. ..- --. .. .- - -. ..- .-.. .-.. .- .--. .- .-. .. .- - ..- .-. . -..- -.-. . .--. - . ..- .-. ... .. -. - --- -.-. -.-. .- . -.-. .- - -.-. ..- .--. .. -.. .- - .- - -. --- -. .--. .-. --- .. -.. . -. - ... ..- -. - .. -. -.-. ..- .-.. .--. .- --.- ..- .. --- ..-. ..-. .. -.-. .. .- -.. . ... . .-. ..- -. - -- --- .-.. .-.. .. - .- -. .. -- .. -.. . ... - .-.. .- -... --- .-. ..- --",
            },
        };

        private static object[] textToCustomMorseMessages =
        {
            new object[] { string.Empty, string.Empty },
            new object[] { "A", "*=" },
            new object[] { "a", "*=" },
            new object[] { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "*=.=***.=*=*.=**.*.**=*.==*.****.**.*===.=*=.*=**.==.=*.===.*==*.==*=.*=*.***.=.**=.***=.*==.=**=.=*==.==**" },
            new object[] { "abcdefghijklmnopqrstuvwxyz", "*=.=***.=*=*.=**.*.**=*.==*.****.**.*===.=*=.*=**.==.=*.===.*==*.==*=.*=*.***.=.**=.***=.*==.=**=.=*==.==**" },
            new object[]
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua*Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat*Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur*Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum*",
                "*=**.===.*=*.*.==.**.*==*.***.**=.==.=**.===.*=**.===.*=*.***.**.=.*=.==.*.=.=*=*.===.=*.***.*.=*=*.=.*.=.**=.*=*.*=.=**.**.*==*.**.***.=*=*.**.=*.==*.*.*=**.**.=.***.*.=**.=**.===.*.**.**=.***.==.===.=**.=.*.==.*==*.===.*=*.**.=*.=*=*.**.=**.**.=**.**=.=*.=.**=.=.*=**.*=.=***.===.*=*.*.*.=.=**.===.*=**.===.*=*.*.==.*=.==*.=*.*=.*=.*=**.**.==*=.**=.*=.**=.=.*.=*.**.==.*=.=**.==.**.=*.**.==.***=.*.=*.**.*=.==.==*=.**=.**.***.=*.===.***.=.*=*.**=.=**.*.=**=.*.*=*.=*=*.**.=.*=.=.**.===.=*.**=.*=**.*=**.*=.==.=*=*.===.*=**.*=.=***.===.*=*.**.***.=*.**.***.**.**=.=.*=.*=**.**.==*=.**=.**.*==*.*.=**=.*.*=.=*=*.===.==.==.===.=**.===.=*=*.===.=*.***.*.==*=.**=.*=.=.=**.**=.**.***.*=.**=.=.*.**.*=*.**=.*=*.*.=**.===.*=**.===.*=*.**.=*.*=*.*.*==*.*=*.*.****.*.=*.=**.*.*=*.**.=.**.=*.***=.===.*=**.**=.*==*.=.*=.=.*.***=.*.*=**.**.=.*.***.***.*.=*=*.**.*=**.*=**.**=.==.=**.===.*=**.===.*=*.*.*.**=.**=*.**=.==*.**.*=.=.=*.**=.*=**.*=**.*=.*==*.*=.*=*.**.*=.=.**=.*=*.*.=**=.=*=*.*.*==*.=.*.**=.*=*.***.**.=*.=.===.=*=*.=*=*.*=.*.=*=*.*=.=.=*=*.**=.*==*.**.=**.*=.=.*=.=.=*.===.=*.*==*.*=*.===.**.=**.*.=*.=.***.**=.=*.=.**.=*.=*=*.**=.*=**.*==*.*=.==*=.**=.**.===.**=*.**=*.**.=*=*.**.*=.=**.*.***.*.*=*.**=.=*.=.==.===.*=**.*=**.**.=.*=.=*.**.==.**.=**.*.***.=.*=**.*=.=***.===.*=*.**=.==",
            },
        };

        private static object[] morseToTextMessages =
        {
            new object[] { string.Empty, string.Empty },
            new object[] { ".-", "A" },
            new object[] { ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --..", "ABCDEFGHIJKLMNOPQRSTUVWXYZ" },
            new object[]
            {
               ".-.. --- .-. . -- .. .--. ... ..- -- -.. --- .-.. --- .-. ... .. - .- -- . - -.-. --- -. ... . -.-. - . - ..- .-. .- -.. .. .--. .. ... -.-. .. -. --. . .-.. .. - ... . -.. -.. --- . .. ..- ... -- --- -.. - . -- .--. --- .-. .. -. -.-. .. -.. .. -.. ..- -. - ..- - .-.. .- -... --- .-. . . - -.. --- .-.. --- .-. . -- .- --. -. .- .- .-.. .. --.- ..- .- ..- - . -. .. -- .- -.. -- .. -. .. -- ...- . -. .. .- -- --.- ..- .. ... -. --- ... - .-. ..- -.. . -..- . .-. -.-. .. - .- - .. --- -. ..- .-.. .-.. .- -- -.-. --- .-.. .- -... --- .-. .. ... -. .. ... .. ..- - .- .-.. .. --.- ..- .. .--. . -..- . .- -.-. --- -- -- --- -.. --- -.-. --- -. ... . --.- ..- .- - -.. ..- .. ... .- ..- - . .. .-. ..- .-. . -.. --- .-.. --- .-. .. -. .-. . .--. .-. . .... . -. -.. . .-. .. - .. -. ...- --- .-.. ..- .--. - .- - . ...- . .-.. .. - . ... ... . -.-. .. .-.. .-.. ..- -- -.. --- .-.. --- .-. . . ..- ..-. ..- --. .. .- - -. ..- .-.. .-.. .- .--. .- .-. .. .- - ..- .-. . -..- -.-. . .--. - . ..- .-. ... .. -. - --- -.-. -.-. .- . -.-. .- - -.-. ..- .--. .. -.. .- - .- - -. --- -. .--. .-. --- .. -.. . -. - ... ..- -. - .. -. -.-. ..- .-.. .--. .- --.- ..- .. --- ..-. ..-. .. -.-. .. .- -.. . ... . .-. ..- -. - -- --- .-.. .-.. .. - .- -. .. -- .. -.. . ... - .-.. .- -... --- .-. ..- --",
               "LOREMIPSUMDOLORSITAMETCONSECTETURADIPISCINGELITSEDDOEIUSMODTEMPORINCIDIDUNTUTLABOREETDOLOREMAGNAALIQUAUTENIMADMINIMVENIAMQUISNOSTRUDEXERCITATIONULLAMCOLABORISNISIUTALIQUIPEXEACOMMODOCONSEQUATDUISAUTEIRUREDOLORINREPREHENDERITINVOLUPTATEVELITESSECILLUMDOLOREEUFUGIATNULLAPARIATUREXCEPTEURSINTOCCAECATCUPIDATATNONPROIDENTSUNTINCULPAQUIOFFICIADESERUNTMOLLITANIMIDESTLABORUM",
            },
        };

        private static object[] customMorseToTextMessages =
        {
            new object[] { string.Empty, string.Empty },
            new object[] { "*=", "A" },
            new object[] { "*=.=***.=*=*.=**.*.**=*.==*.****.**.*===.=*=.*=**.==.=*.===.*==*.==*=.*=*.***.=.**=.***=.*==.=**=.=*==.==**", "ABCDEFGHIJKLMNOPQRSTUVWXYZ" },
            new object[]
            {
                "*=**.===.*=*.*.==.**.*==*.***.**=.==.=**.===.*=**.===.*=*.***.**.=.*=.==.*.=.=*=*.===.=*.***.*.=*=*.=.*.=.**=.*=*.*=.=**.**.*==*.**.***.=*=*.**.=*.==*.*.*=**.**.=.***.*.=**.=**.===.*.**.**=.***.==.===.=**.=.*.==.*==*.===.*=*.**.=*.=*=*.**.=**.**.=**.**=.=*.=.**=.=.*=**.*=.=***.===.*=*.*.*.=.=**.===.*=**.===.*=*.*.==.*=.==*.=*.*=.*=.*=**.**.==*=.**=.*=.**=.=.*.=*.**.==.*=.=**.==.**.=*.**.==.***=.*.=*.**.*=.==.==*=.**=.**.***.=*.===.***.=.*=*.**=.=**.*.=**=.*.*=*.=*=*.**.=.*=.=.**.===.=*.**=.*=**.*=**.*=.==.=*=*.===.*=**.*=.=***.===.*=*.**.***.=*.**.***.**.**=.=.*=.*=**.**.==*=.**=.**.*==*.*.=**=.*.*=.=*=*.===.==.==.===.=**.===.=*=*.===.=*.***.*.==*=.**=.*=.=.=**.**=.**.***.*=.**=.=.*.**.*=*.**=.*=*.*.=**.===.*=**.===.*=*.**.=*.*=*.*.*==*.*=*.*.****.*.=*.=**.*.*=*.**.=.**.=*.***=.===.*=**.**=.*==*.=.*=.=.*.***=.*.*=**.**.=.*.***.***.*.=*=*.**.*=**.*=**.**=.==.=**.===.*=**.===.*=*.*.*.**=.**=*.**=.==*.**.*=.=.=*.**=.*=**.*=**.*=.*==*.*=.*=*.**.*=.=.**=.*=*.*.=**=.=*=*.*.*==*.=.*.**=.*=*.***.**.=*.=.===.=*=*.=*=*.*=.*.=*=*.*=.=.=*=*.**=.*==*.**.=**.*=.=.*=.=.=*.===.=*.*==*.*=*.===.**.=**.*.=*.=.***.**=.=*.=.**.=*.=*=*.**=.*=**.*==*.*=.==*=.**=.**.===.**=*.**=*.**.=*=*.**.*=.=**.*.***.*.*=*.**=.=*.=.==.===.*=**.*=**.**.=.*=.=*.**.==.**.=**.*.***.=.*=**.*=.=***.===.*=*.**=.==",
                "LOREMIPSUMDOLORSITAMETCONSECTETURADIPISCINGELITSEDDOEIUSMODTEMPORINCIDIDUNTUTLABOREETDOLOREMAGNAALIQUAUTENIMADMINIMVENIAMQUISNOSTRUDEXERCITATIONULLAMCOLABORISNISIUTALIQUIPEXEACOMMODOCONSEQUATDUISAUTEIRUREDOLORINREPREHENDERITINVOLUPTATEVELITESSECILLUMDOLOREEUFUGIATNULLAPARIATUREXCEPTEURSINTOCCAECATCUPIDATATNONPROIDENTSUNTINCULPAQUIOFFICIADESERUNTMOLLITANIMIDESTLABORUM",
            },
        };

        [Test]
        public void TranslateToMorse_MessageIsNull_ThrowsArgumentNullException()
        {
            // Act
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => Translator.TranslateToMorse(null));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestCaseSource(nameof(textToMorseMessages))]
        public void TranslateToMorse_ParametersAreValid_WritesMorseMessageToStringBuilder(string message, string expectedResult)
        {
            // Act
            string actualResult = Translator.TranslateToMorse(message);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TranslateToText_MorseMessageIsNull_ThrowsArgumentNullException()
        {
            // Act
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => Translator.TranslateToText(null));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestCaseSource(nameof(morseToTextMessages))]
        public void TranslateToText_ParametersAreValid_WritesTextMessageToStringBuilder(string message, string expectedResult)
        {
            // Act
            string actualResult = Translator.TranslateToText(message);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void WriteMorse_CodeTableIsNull_ThrowsArgumentNullException()
        {
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            // Act
            Assert.Throws<ArgumentNullException>(() => Translator.WriteMorse(null, string.Empty, new StringBuilder()));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [Test]
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        public void WriteMorse_MessageIsNull_ThrowsArgumentNullException()
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        {
            // Act
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => Translator.WriteMorse(null, string.Empty, new StringBuilder()));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.

        [Test]
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        public void WriteMorse_MorseMessageBuilderIsNull_ThrowsArgumentNullException()
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        {
            // Act
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => Translator.WriteMorse(MorseCodes.CodeTable, string.Empty, null));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestCaseSource(nameof(textToMorseMessages))]
        public void WriteMorse_DefaultParameters_WritesMorseMessageToStringBuilder(string message, string expectedResult)
        {
            // Arrange
            StringBuilder morseMessageBuilder = new StringBuilder();

            // Act
            Translator.WriteMorse(MorseCodes.CodeTable, message, morseMessageBuilder);

            // Assert
            string actualResult = morseMessageBuilder.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCaseSource(nameof(textToCustomMorseMessages))]
        public void WriteMorse_CustomParameters_WritesMorseMessageToStringBuilder(string message, string expectedResult)
        {
            // Arrange
            StringBuilder morseMessageBuilder = new StringBuilder();

            // Act
            Translator.WriteMorse(MorseCodes.CodeTable, message, morseMessageBuilder, '*', '=', '.');

            // Assert
            string actualResult = morseMessageBuilder.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void WriteText_CodeTableIsNull_ThrowsArgumentNullException()
        {
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            // Act
            Assert.Throws<ArgumentNullException>(() => Translator.WriteText(null, string.Empty, new StringBuilder()));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [Test]
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        public void WriteText_MorseMessageIsNull_ThrowsArgumentNullException()
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        {
            // Act
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.Throws<ArgumentNullException>(() => Translator.WriteText(MorseCodes.CodeTable, null, new StringBuilder()));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.

        [Test]
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        public void WriteText_MessageBuilderIsNull_ThrowsArgumentNullException()
        {
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            // Act
            Assert.Throws<ArgumentNullException>(() => Translator.WriteText(MorseCodes.CodeTable, string.Empty, null));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestCaseSource(nameof(morseToTextMessages))]
        public void WriteText_DefaultParameters_WritesTextMessageToStringBuilder(string message, string expectedResult)
        {
            // Arrange
            StringBuilder messageBuilder = new StringBuilder();

            // Act
            Translator.WriteText(MorseCodes.CodeTable, message, messageBuilder);

            // Assert
            string actualResult = messageBuilder.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCaseSource(nameof(customMorseToTextMessages))]
        public void WriteText_CustomParameters_WritesTextMessageToStringBuilder(string message, string expectedResult)
        {
            // Arrange
            StringBuilder messageBuilder = new StringBuilder();

            // Act
            Translator.WriteText(MorseCodes.CodeTable, message, messageBuilder, '*', '=', '.');

            // Assert
            string actualResult = messageBuilder.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
