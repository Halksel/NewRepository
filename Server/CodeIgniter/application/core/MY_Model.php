<?php defined('BASEPATH') OR exit('No direct script access allowed');
class MY_Model extends CI_Model{
  protected $_table;
  protected $timestamps_format = 'Y-m-d H:i:s';
  public function __construct(){
    parent::__construct();
    $this->load->database();
    $class = get_class($this);
    $this->_table = substr($class, 0, strpos($class, '_'));
  }
  public function get(){
    return $this->db->get($this->_table);
//     return $this->db->get($this->_table)->result();
  }
  public function get_where($where){
    return $this->db->get_where($this->_table,$where)->result();
  }
  public function insert($data){
    $this->db->set($data); 
    $this->db->insert($this->_table);
    return $this->db->insert_id();
  }
  public function replace($data){
    $this->db->set($data); 
    $this->db->replace($this->_table);
    return $this->db->insert_id();
  }
  public function set_order_by($datas){
    foreach($datas as $key => $value){
      $this->db->order_by($key,$value); 
    }
  }
  public function count_all(){
    return $this->db->count_all_results($this->_table);
  }
}
