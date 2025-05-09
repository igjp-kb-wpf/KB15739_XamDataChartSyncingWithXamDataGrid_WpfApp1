using KB15739_WpfApp1.Infrastructure;
using KB15739_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB15739_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<SampleChartDataItem> _sampeChartData;
    public ObservableCollection<SampleChartDataItem> SampleChartData
    {
        get { return _sampeChartData; }
        set { _sampeChartData = value; OnPropertyChanged(); }
    }

    // Y軸の最大値を設定・取得するプロパティ
    private int _maximumY = 200;
    public int MaximumY
    {
        get { return _maximumY; }
        set { _maximumY = value; OnPropertyChanged(); }
    }

    // Y軸の最少値を設定・取得するプロパティ
    private int _minimumY = 0;
    public int MinimumY
    {
        get { return _minimumY; }
        set { _minimumY = value; OnPropertyChanged(); }
    }

    // XamDataGridで選択されているデータ項目を設定・取得するプロパティ
    private SampleChartDataItem? _selectedDataItem = null;
    public SampleChartDataItem? SelectedDataItem
    {
        get { return _selectedDataItem; }
        set
        {
            if (_selectedDataItem != value)
            {
                _selectedDataItem = value;
                OnPropertyChanged();

                foreach (var chartDataItem in SampleChartData)
                {
                    if (_selectedDataItem != null && chartDataItem.YearLabel == _selectedDataItem.YearLabel)
                    {
                        chartDataItem.AmountForHighlight = _maximumY;
                    }
                    else
                    {
                        chartDataItem.AmountForHighlight = _minimumY;
                    }
                }
            }
        }
    }

    public MainWindowViewModel()
    {
        _sampeChartData = new ()
        {
            new () { YearLabel = "1998", Amount1 = 162, Amount2 = 93, AmountForHighlight = _minimumY },
            new () { YearLabel = "1999", Amount1 = 57, Amount2 = 140, AmountForHighlight = _minimumY },
            new () { YearLabel = "2000", Amount1 = 92, Amount2 = 134, AmountForHighlight = _minimumY },
            new () { YearLabel = "2001", Amount1 = 105, Amount2 = 74, AmountForHighlight = _minimumY },
            new () { YearLabel = "2002", Amount1 = 81, Amount2 = 89, AmountForHighlight = _minimumY },
        };
    }
}
