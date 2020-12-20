/*
 * Revenue Management System
 *
 * Florida Fish and Wildlife Conservation Commision - Revenue Management System.
 *
 */
namespace FWC.RMS.ApplicationCore.Data
{
	public abstract class BaseEntity<TIdType>
	{
		public virtual TIdType Id { get; set; }
	}
}
