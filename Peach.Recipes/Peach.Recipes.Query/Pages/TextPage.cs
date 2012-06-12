using CuttingEdge.Conditions;
using Xyperico.Base;


namespace Peach.Recipes.Query.Pages
{
  public class TextPage : Page
  {
    #region Public persisted properties

    public string Content { get; protected set; }

    #endregion


    public TextPage(string title, int pageNo, string content)
      : base(title, pageNo)
    {
      Condition.Requires(content, "content").IsNotNull();

      Content = content;
    }


    public override string TemplateName
    {
      get { return "text"; }
    }


    public override void InitializeForView(IObjectResolver resolver)
    {
    }
  }
}
