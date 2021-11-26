using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartEmployee.Web.Data;
using SmartEmployee.Web.Data.Entities;

namespace SmartEmployee.Web.Controllers
{
    public class SocialSecurityController : Controller
    {
        private readonly DataContext _context;

        public SocialSecurityController(DataContext context)
        {
            _context = context;
        }

        #region // Afp
        public async Task<IActionResult> IndexAfp()
        {
            return View(await _context.Afps.ToListAsync());
        }


        // GET: SocialSecurity/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var afp = await _context.Afps
        //        .FirstOrDefaultAsync(m => m.afpId == id);
        //    if (afp == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(afp);
        //}

        #region // Create Afp
        public IActionResult CreateAfp()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAfp([Bind("afpId,afpName,afpNit")] Afp afp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(afp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexAfp));
            }
            return View(afp);
        }
        #endregion

        #region // Edit Afp
        public async Task<IActionResult> EditAfp(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afp = await _context.Afps.FindAsync(id);
            if (afp == null)
            {
                return NotFound();
            }
            return View(afp);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAfp(int id, [Bind("afpId,afpName,afpNit")] Afp afp)
        {
            if (id != afp.afpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(afp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AfpExists(afp.afpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexAfp));
            }
            return View(afp);
        }
        #endregion

        #region // Delete Afp
        public async Task<IActionResult> DeleteAfp(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afp = await _context.Afps
                .FirstOrDefaultAsync(m => m.afpId == id);
            if (afp == null)
            {
                return NotFound();
            }

            return View(afp);
        }

        
        [HttpPost, ActionName("DeleteAfp")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAfpConfirmed(int id)
        {
            var afp = await _context.Afps.FindAsync(id);
            _context.Afps.Remove(afp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAfp));
        }
        #endregion

        private bool AfpExists(int id)
        {
            return _context.Afps.Any(e => e.afpId == id);
        }

        #endregion

        #region // Arl
        public async Task<IActionResult> IndexArl()
        {
            return View(await _context.Arls.ToListAsync());
        }


        #region // Create Arl
        public IActionResult CreateArl()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateArl([Bind("arlId,arlName,arlNit")] Arl arl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexArl));
            }
            return View(arl);
        }
        #endregion

        #region // Edit Arl
        public async Task<IActionResult> EditArl(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arl = await _context.Arls.FindAsync(id);
            if (arl == null)
            {
                return NotFound();
            }
            return View(arl);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditArl(int id, [Bind("arlId,arlName,arlNit")] Arl arl)
        {
            if (id != arl.arlId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArlExists(arl.arlId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexArl));
            }
            return View(arl);
        }
        #endregion

        #region // Delete Arl
        public async Task<IActionResult> DeleteArl(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arl = await _context.Arls
                .FirstOrDefaultAsync(m => m.arlId == id);
            if (arl == null)
            {
                return NotFound();
            }

            return View(arl);
        }


        [HttpPost, ActionName("DeleteArl")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteArlConfirmed(int id)
        {
            var arl = await _context.Arls.FindAsync(id);
            _context.Arls.Remove(arl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexArl));
        }
        #endregion

        private bool ArlExists(int id)
        {
            return _context.Arls.Any(e => e.arlId == id);
        }

        #endregion

        #region // Eps
        public async Task<IActionResult> IndexEps()
        {
            return View(await _context.Epses.ToListAsync());
        }


        #region // Create Eps
        public IActionResult CreateEps()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEps([Bind("epsId,epsName,epsNit")] Eps eps)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eps);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexEps));
            }
            return View(eps);
        }
        #endregion

        #region // Edit Eps
        public async Task<IActionResult> EditEps(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eps = await _context.Epses.FindAsync(id);
            if (eps == null)
            {
                return NotFound();
            }
            return View(eps);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEps(int id, [Bind("epsId,epsName,epsNit")] Eps eps)
        {
            if (id != eps.epsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eps);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EpsExists(eps.epsId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexEps));
            }
            return View(eps);
        }
        #endregion

        #region // Delete Eps
        public async Task<IActionResult> DeleteEps(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eps = await _context.Epses
                .FirstOrDefaultAsync(m => m.epsId == id);
            if (eps == null)
            {
                return NotFound();
            }

            return View(eps);
        }


        [HttpPost, ActionName("DeleteEps")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteEpsConfirmed(int id)
        {
            var eps = await _context.Epses.FindAsync(id);
            _context.Epses.Remove(eps);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexEps));
        }
        #endregion

        private bool EpsExists(int id)
        {
            return _context.Epses.Any(e => e.epsId == id);
        }

        #endregion

        #region // Ccf
        public async Task<IActionResult> IndexCcf()
        {
            return View(await _context.Ccfs.ToListAsync());
        }


        #region // Create Ccf
        public IActionResult CreateCcf()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCcf([Bind("ccfId,ccfName,ccfNit")] Ccf ccf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ccf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexCcf));
            }
            return View(ccf);
        }
        #endregion

        #region // Edit Ccf
        public async Task<IActionResult> EditCcf(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ccf = await _context.Ccfs.FindAsync(id);
            if (ccf == null)
            {
                return NotFound();
            }
            return View(ccf);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCcf(int id, [Bind("ccfId,ccfName,ccfNit")] Ccf ccf)
        {
            if (id != ccf.ccfId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ccf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CcfExists(ccf.ccfId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexCcf));
            }
            return View(ccf);
        }
        #endregion

        #region // Delete Ccf
        public async Task<IActionResult> DeleteCcf(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ccf = await _context.Ccfs
                .FirstOrDefaultAsync(m => m.ccfId == id);
            if (ccf == null)
            {
                return NotFound();
            }

            return View(ccf);
        }


        [HttpPost, ActionName("DeleteCcf")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCcfConfirmed(int id)
        {
            var ccf = await _context.Ccfs.FindAsync(id);
            _context.Ccfs.Remove(ccf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexCcf));
        }
        #endregion

        private bool CcfExists(int id)
        {
            return _context.Ccfs.Any(e => e.ccfId == id);
        }

        #endregion
    }
}
