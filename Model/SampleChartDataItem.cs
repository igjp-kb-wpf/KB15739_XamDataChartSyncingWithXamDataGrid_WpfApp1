using KB15739_WpfApp1.Infrastructure;

namespace KB15739_WpfApp1.Model;
internal class SampleChartDataItem : ObservableObject
{
    private String _yearLabel = "";
    public String YearLabel
    {
        get { return _yearLabel; }
        set { _yearLabel = value; OnPropertyChanged(); }
    }

    // StepLineSeries 1 つめのデータです。
    private int _amount1;
    public int Amount1
    {
        get { return _amount1; }
        set { _amount1 = value; OnPropertyChanged(); }
    }

    // StepLineSeries 2 つめのデータです。
    private int _amount2;
    public int Amount2
    {
        get { return _amount2; }
        set { _amount2 = value; OnPropertyChanged(); }
    }

    // ハイライト用のデータです。
    // ハイライトされていない場合はY軸の最小値が入る、
    // ハイライトされている場合はY軸の最大値が入る、
    // という想定です。
    private int _amountForHighlight;
    public int AmountForHighlight
    {
        get { return _amountForHighlight; }
        set { _amountForHighlight = value; OnPropertyChanged(); }
    }

    public SampleChartDataItem()
    {
    }
}