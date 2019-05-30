<?php
#http://localhost/Server/CodeIgniter/index.php/Tanks/index
class Tmp extends My_Controller{
  public function __construct(){
    parent::__construct();
  }
	public function index()
	{
    parent::index();
  }
  public function Users(){
    $users = $this->Tmp_model->get();
    foreach($users as $user){
      var_dump($user->id);
      var_dump($user->name);
      var_dump($user->level);
    }
  }
  
}
