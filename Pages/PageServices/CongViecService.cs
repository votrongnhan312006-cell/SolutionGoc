using IDC.Frontend.Services;
using QLCongViec.Dto;
using QLCongViec.Models;

namespace QLCongViec.Services
{
public class CongViecService
{
private readonly ClientServices _client;

public CongViecService(ClientServices client)
{
_client = client;
}

public async Task<List<tbNguoiPhoiHop>> GetPhoiHopList(int congViecId)
{
string filterExp = $"IdCongViec=={congViecId}";
if (congViecId == 0) return new List<tbNguoiPhoiHop>();
return await _client.apiSevices.GetAll<tbNguoiPhoiHop>(filterExp);
}

public string? BuildFileLambda(string? idTaiLieu)
{
if (string.IsNullOrEmpty(idTaiLieu)) return null;
var uids = idTaiLieu.Split("|", StringSplitOptions.RemoveEmptyEntries);
return $"p=>p.uid.Contains(\"{string.Join("\") || p.uid.Contains(\"", uids)}\")";
}

public void AddPhoiHop(tbNguoiPhoiHop phoiHop, List<tbNguoiPhoiHop> list)
{
list.Add(phoiHop);
}

public void DeletePhoiHop(tbNguoiPhoiHop phoiHop, List<tbNguoiPhoiHop> list, List<tbNguoiPhoiHop> deleted)
{
if (phoiHop.IdNguoiPhoiHop > 0) deleted.Add(phoiHop);
list.Remove(phoiHop);
}

public async Task SubmitCongViec(tbCongViec congviec, List<tbNguoiPhoiHop> phoiHopList, List<FileUpload> uploadedFiles)
{
congviec.IdTaiLieu = uploadedFiles.Any()
? string.Join("|", uploadedFiles.Select(f => f.uid))
: null;

if (congviec.IdCongViec == 0)
{
congviec.IdCongViec = await _client.numServices.GetInt<tbCongViec>("seq_tbCongViec");
await _client.apiSevices.Create<tbCongViec>(congviec);
}
else
{
await _client.apiSevices.Update<tbCongViec>(congviec);
}

foreach (var phoiHop in phoiHopList.Where(p => p.HoTen != null && p.NguoiGiao != null))
{
phoiHop.IdCongViec = congviec.IdCongViec;
if (phoiHop.IdNguoiPhoiHop == 0)
{
phoiHop.IdNguoiPhoiHop = await _client.numServices.GetInt<tbNguoiPhoiHop>("seq_tbNguoiPhoiHop");
await _client.apiSevices.Create<tbNguoiPhoiHop>(phoiHop);
}
else
{
await _client.apiSevices.Update<tbNguoiPhoiHop>(phoiHop);
}
}

if (phoiHopList.Any()) congviec.HasNguoiPhoiHop = true;
await _client.apiSevices.Update<tbCongViec>(congviec);
}
}
}