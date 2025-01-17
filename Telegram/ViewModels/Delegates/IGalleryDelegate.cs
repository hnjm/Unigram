//
// Copyright Fela Ameghino 2015-2023
//
// Distributed under the GNU General Public License v3.0. (See accompanying
// file LICENSE or copy at https://www.gnu.org/licenses/gpl-3.0.txt)
//
using Telegram.Services;
using Telegram.Td.Api;
using Telegram.ViewModels.Gallery;

namespace Telegram.ViewModels.Delegates
{
    public interface IGalleryDelegate
    {
        IClientService ClientService { get; }

        void OpenItem(GalleryMedia item);
        void OpenFile(GalleryMedia item, File file);
    }
}
