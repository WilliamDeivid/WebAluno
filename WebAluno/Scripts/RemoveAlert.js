function delete_alert(clicked_id)
{
  var no = document.getElementById(clicked_id);
  if (no.parentNode) {
    no.parentNode.removeChild(no);
  }
}
