// Define the report object and its properties
public class Report
{
    public List<DataSource> DataSources { get; set; }
    public List<Filter> Filters { get; set; }
    public List<Visualization> Visualizations { get; set; }

    // Define the Clone method for the Prototype pattern
    public Report Clone()
    {
        return (Report)this.MemberwiseClone();
    }
}

// Define the builder for creating report objects
public class ReportBuilder
{
    private Report _report = new Report();

    // Define methods for adding data sources, filters, and visualizations
    public void AddDataSource(DataSource dataSource)
    {
        _report.DataSources.Add(dataSource);
    }

    public void AddFilter(Filter filter)
    {
        _report.Filters.Add(filter);
    }

    public void AddVisualization(Visualization visualization)
    {
        _report.Visualizations.Add(visualization);
    }

    // Define a method for returning the finished report object
    public Report GetReport()
    {
        return _report;
    }
}

// Define the data source, filter, and visualization classes
public class DataSource
{
    public string Name { get; set; }
    public string ConnectionString { get; set; }
}

public class Filter
{
    public string Field { get; set; }
    public string Operator { get; set; }
    public string Value { get; set; }
}

public class Visualization
{
    public string Type { get; set; }
    public string Source { get; set; }
}


// Create the builder object
var builder = new ReportBuilder();

// Add data sources, filters, and visualizations to the report
builder.AddDataSource(new DataSource { Name = "Sales Data", ConnectionString = "SalesDB" });
builder.AddFilter(new Filter { Field = "Region", Operator = "Equals", Value = "West" });
builder.AddVisualization(new Visualization { Type = "Bar Chart", Source = "Sales Data" });

// Use the builder to create a new report object
var report1 = builder.GetReport();

// Use the prototype pattern to create a copy of the report with different visualizations
var report2 = report1.Clone();
report2.Visualizations.Add(new Visualization { Type = "Line Chart", Source = "Sales Data" });
