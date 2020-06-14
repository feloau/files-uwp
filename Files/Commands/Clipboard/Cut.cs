using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;

namespace Files.Commands.Clipboard
{
    internal class Cut
    {
        public async void CutCommand(string ItemPath)
        {
            try
            {
                StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(ItemPath);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}