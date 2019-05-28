<?php defined('BASEPATH') OR exit('No direct script access allowed');
class MY_Controller extends CI_Controller{
  protected $_name;
  public function __construct(){
    parent::__construct();
  }
  public function model()
  {
      $class = get_class($this);
      $this->_name = strtolower(substr($class, 0, strpos($class, '_')));
      $this->_name = $this->_name . '_model';
      if (!isset($this->_name)) {
          $this->load->model($this->_name);
      }
      return $this->_name;
  }
  public function index(){
    echo "hello My_controller";
  }

}
