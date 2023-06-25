using System.Collections.ObjectModel;

namespace PharC;

//*Nejla* view model
public class AdsViewModel
{
    public ObservableCollection<AdsModel> Ads { get; set; } = new ObservableCollection<AdsModel>
    {
        new AdsModel()
        {
            Image = "ad1.png "
        },
        new AdsModel()
        {
            Image = "ad2.png "
        },
        new AdsModel()
        {
            Image = "ad3.png "
        },
        new AdsModel()
        {
            Image = "ad4.png "
        },
    };


}