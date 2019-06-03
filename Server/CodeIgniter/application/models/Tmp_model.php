<?php defined('BASEPATH') OR exit('No direct script access allowed');
class Tmp_model extends MY_model{
  public function __construct(){
    parent::__construct();
  }
//   public function replace_data($data){
//     $id = $this->replace($data);
//     return $this->get_where(array('id' => $data['id'])); 
//   }
  public function replace_data(){
    $this->load->helper('url');
    $user = array(
      'id' => $this->input->post('id'),
      'name' => $this->input->post('name'),
      'level' => $this->input->post('level')
    );
    $this->replace($user);
    return $this->get_where(array('id' => $user['id'])); 
  }
  
}
