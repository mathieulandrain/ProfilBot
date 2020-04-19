using Discord;
using Discord.Commands;
using GLR.Core.Services;
using System;
using System.Threading.Tasks;

namespace GLR.Core.Commands.Modules
{
    public class ProfileModule : GLRModule<SocketCommandContext>
    {
        private ProfileService _profileService;

        public ProfileModule(ProfileService profileService)
        {
            _profileService = profileService;
        }

        [Command("profil", RunMode = RunMode.Async)]
        public async Task ShowProfile([Remainder]string userName)
        {
            var profile = await _profileService.GetProfileAsync(userName);
            if (profile == null) 
            {
                await ReplyAsync("Profil non trouvé."); return;
            }

            var embed = new EmbedBuilder()
                .WithTitle($"Profil de jeu pour {profile.UserName}")
                .WithUrl(profile.Url)
                .WithThumbnailUrl(profile.ImageUrl)
                .WithDescription($"\nL'ID de l'utilisateur est **{profile.Id}**.")
                .AddField("Friends", $"Il a **{profile.AmountOfFriends}** amis." +
                    $"\nIl a **{profile.AmountOfIncomingRequests}** demandes d'amis en attente." +
                    $"\nIl a envoyé **{profile.AmountOfOutgoingRequests}** demandes d'amis en attente.")
                .WithFooter($"Il a créer son compte le {profile.CreationDate.ToLongDateString()}")
                .Build();

            await ReplyAsync("", false, embed);
        }

        [Command("profile", RunMode = RunMode.Async)]
        public async Task ShowProfile()
        {
            var name = Context.User.Username;

            var profile = await _profileService.GetProfileAsync(name);
            if (profile == null) 
            {
                await ReplyAsync("Profil non trouvé."); return;
            }

            var embed = new EmbedBuilder()
                .WithTitle($"Profil de jeu pour {profile.UserName}")
                .WithUrl(profile.Url)
                .WithThumbnailUrl(profile.ImageUrl)
                .WithDescription($"\nL'ID de l'utilisateur est **{profile.Id}**.")
                .AddField("Friends", $"Il a **{profile.AmountOfFriends}** amis." +
                    $"\nIl a **{profile.AmountOfIncomingRequests}** demandes d'amis en attente." +
                    $"\nIl a envoyé **{profile.AmountOfOutgoingRequests}** demandes d'amis en attente.")
                .WithFooter($"Il a créer son compte le {profile.CreationDate.ToLongDateString()}")
                .Build();

            await ReplyAsync("", false, embed);
        }
    }
}
