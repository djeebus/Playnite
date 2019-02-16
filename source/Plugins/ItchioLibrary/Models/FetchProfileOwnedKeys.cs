﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItchioLibrary.Models
{
    /// <summary>
    /// A DownloadKey is often generated when a purchase is made, it allows downloading uploads for a game that are not available for free.
    /// It can also be generated by other means.
    /// </summary>
    public class DownloadKey
    {
        /// <summary>
        /// Site-wide unique identifier generated by itch.io
        /// </summary>
        public long id;

        /// <summary>
        /// Identifier of the game to which this download key grants access
        /// </summary>
        public long gameId;

        /// <summary>
        /// Game to which this download key grants access
        /// </summary>
        public ItchioGame game;

        /// <summary>
        /// Date this key was created at (often coincides with purchase time)
        /// </summary>
        public DateTime? createdAt;

        /// <summary>
        /// Date this key was last updated at
        /// </summary>
        public DateTime? updatedAt;

        /// <summary>
        /// Identifier of the itch.io user to which this key belongs
        /// </summary>
        public long ownerId;
    }

    public class FetchProfileOwnedKeys
    {
        /// <summary>
        /// Download keys fetched for profile
        /// </summary>
        public List<DownloadKey> items;
    }
}
