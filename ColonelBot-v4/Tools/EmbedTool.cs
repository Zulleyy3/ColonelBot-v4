﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

//This class is for quickly constructing an embed with a default setup for quick responses.
//TODO: Update this to mirror ChannelMessages' build.
namespace ColonelBot_v4.Tools
{
    public class EmbedTool
    {
        public static Embed ChannelMessage(string Message, SocketSelfUser user)
        {
            var embed = new EmbedBuilder
            {
                //Author = new EmbedAuthorBuilder
                //{
                //    Name = user.ToString(),
                //    IconUrl = user.GetAvatarUrl()
                //},
                Color = new Color(0xffcf39)
            };

            embed.AddField("Response", Message);
            
            return embed.Build();
        }


        public static Embed HelpMessage(string CommandTitle, string Contents)
        {
            EmbedBuilder embed = new EmbedBuilder
            {
                Color = new Color(0xffcf39)
            };
            embed.AddField(CommandTitle, Contents);
            return embed.Build();
        }

        public static Embed UserJoinLog(SocketGuildUser user)
        {
            EmbedBuilder embed = new EmbedBuilder
            {
                Color = new Color(0x00ff00)
            };
            embed.AddField("Account Name", user.Username);
            embed.AddField("User ID", user.Id.ToString());
            embed.ThumbnailUrl = user.GetAvatarUrl();
            if (user.Nickname != null)
                embed.AddField("Nickname", user.Nickname);
            return embed.Build();
        }

        public static Embed UserLeaveLog(SocketGuildUser user)
        {
            EmbedBuilder embed = new EmbedBuilder
            {
                Color = new Color(0xff0000)
            };
            embed.AddField("Account Name", user.Username);
            embed.AddField("User ID", user.Id.ToString());
            embed.ThumbnailUrl = user.GetAvatarUrl();
            if (user.Nickname != null)
                embed.AddField("Nickname", user.Nickname);

            return embed.Build();
        }

        //public static Embed WelcomeEmbed(SocketGuildUser user, SocketGuildUser WelcomeTargetUser)
        //{//WelcomeTargetUser is default to the caller of the command or the @ tag otherwise.
        //    EmbedBuilder embed = new EmbedBuilder
        //    {
        //        Color = new Color(0xffcf39) //ColonelBot's Default Yellow
        //    };
        //    embed.AddField("Warning", "The N1 Grand Prix cannot provide ROMs. We strongly suggest ripping your own ROM from a physical cart provided that it complies with your country's copyright laws.");
        //    embed.AddField("How To Netbattle Online [Video Guides]", "These will show you how to import your save file, netbattle as a host, and netbattle as a Client.  \nhttp://bit.ly/2htNN8W");
        //    embed.AddField("Netbattle 101 Guide", "This guide, written by the community, will give you everything you need to get started.\nhttp://bit.ly/1Rr14oN");
        //    embed.AddField("Participant OneDrive", "This folder contains all the saves, patches, and extra info you will need to Netbattle. \nhttps://1drv.ms/f/s!AlnkPup_z_U0tZUD-gZeNJ6BsSnkuA");
        //    embed.AddField("Netbattle 101 EX", "A comprehensive set of guides for more advanced techniques and information.\nhttp://bit.ly/1RszYzG");
        //    embed.AddField("Rockman.EXE 6 ModCard Guide", "Comprehensive guide on ModCards, their effects, and other information.\nhttps://goo.gl/XWHdNS");
        //    embed.AddField("VirtualDub Audio Syncing", "This guide will assist you in syncing your audio and video when recording matches with VBA\nhttp://bit.ly/2vAgmrt");
        //}
    }
}