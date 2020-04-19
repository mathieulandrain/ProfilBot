using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace GLR.Core.Commands.Modules
{
    public class UserSpecificModule : GLRModule<SocketCommandContext>
    {
        [Command("merci")]
        public async Task merci()
        {
             await ReplyAsync("https://tenor.com/view/cute-bear-thank-you-thanks-gif-14105969");
        }

        [Command("tropico")]
        public async Task tropico()
        {
             await ReplyAsync("**L'image dit tout:**");
            await Context.Channel.SendFileAsync("assets/tropico.png");
            await ReplyAsync("A l'eau de source **Attention**!");
        }

        [Command("mathieu")]
        public async Task mathieu()
        {
            await ReplyAsync("**Mathieu Landrain:** Je suis commandant veuilliez me respecter et m'obeir!");
        }

        [Command("alexis")]
        public async Task alexis()
        {
            var embed = new EmbedBuilder().WithTitle("Le sergent Alexis.").WithColor(Color.Red)
            .WithDescription("Si je stream tu viens ok ?!\n\n**Lien:** [Alors follow maintenant !](https://www.twitch.tv/ur_de4d)")
            .WithThumbnailUrl("https://static-cdn.jtvnw.net/jtv_user_pictures/67fd886b-5ff2-4511-ab9c-3abcb20d1208-profile_image-70x70.png").Build();
            await ReplyAsync(":HappyChief: :nuke:", false, embed);
        }
        
        [Command("liiafa")]
        public async Task liiafa()
        {
            var embed = new EmbedBuilder().WithTitle("Le chef Liiafa.").WithColor(Color.Red)
            .WithDescription("Je suis sur Twitch viens me follow sinon la sentence sera irrévocable...\n\n**Lien:** [Si tu clique pas **Attention** à toi !](https://twitch.tv/liiafa)")
            .WithThumbnailUrl("https://static-cdn.jtvnw.net/jtv_user_pictures/66eae663-c2a0-4046-81c2-20eaaf803525-profile_image-70x70.png").Build();
            await ReplyAsync(":HappyChief: :nuke:", false, embed);
        }

[Command("bambie")]
        public async Task bambie()
        {
            await ReplyAsync("**C'est trop meugnon**");
            var message = await Context.Channel.SendFileAsync("assets/bambie.png");
            var heartEmoji = new Emoji(":heart:");          
            await message.AddReactionAsync(heartEmoji);
            await ReplyAsync("Si tu aime réagit avec un coeur");
        }

        [Command("status")]
        public async Task status(){
            var embed = new EmbedBuilder().WithTitle("Status de serveur").WithColor(Color.Green)
            .WithDescription("Si tu veux connaître les statuts de serveur GLR.\n\n**Clic:** [ici](https://galaxylifereborn.com/status)")
            .WithThumbnailUrl("https://galaxylifereborn.com/assets/img/logo.png").Build();
            await ReplyAsync(":glr:", false, embed);
        }

    }
};
