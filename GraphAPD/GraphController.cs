using System;
using System.Collections;


namespace GraphAPD
{
    public interface IShapeView
    {
        void RefreshView();
    }

    public class GraphController
    {
        private ArrayList ViewList;

		// constructor
        public GraphController()
		{
			ViewList = new ArrayList();
		}
        
		/// <summary>method: AddView
		/// add view to viewlist
		/// </summary>
		/// <param name="aView"></param>
		public void AddView(IShapeView aView)
		{
			ViewList.Add(aView);
		}

		/// <summary>method: UpdateViews
		/// update each view 
		/// </summary>
		public void UpdateViews()
		{
			IShapeView[] theViews = (IShapeView[])ViewList.ToArray(typeof(IShapeView));
			foreach (IShapeView v in theViews)
			{
				v.RefreshView();
			}
		}
    }
}
