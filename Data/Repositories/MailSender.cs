using ComponentesMexica.Data.Models;
using Microsoft.AspNetCore.Identity;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using MailKit.Net.Smtp;
using MailKit;
using System.Reflection.Metadata;

namespace ComponentesMexica.Data.Repositories
{
    public class MailSender
    {
        protected string Admin = "danulricht@hotmail.com";
        protected string smtpserver = "smtp.gmail.com";
        protected int Port = 587;
        protected string Sender = "jsmailsend1@gmail.com";
        protected string pwd = "11010106";
        protected string Soporte = "Soporte Componentes Mexica";
        protected string Ventas = "Ventas Componentes Mexica";
        protected string Envios = "";
        protected private void SMTPDATA(MimeMessage message)
        {
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(smtpserver, Port, false);
                client.Authenticate(Sender, pwd);
                client.Send(message);
                client.Disconnect(true);
            }
        }
        protected MimeMessage Message(MailboxAddress From, MailboxAddress To, string text, string subject,string backurl)
        {
            var x = new MimeMessage();
            x.From.Add(From);
            x.To.Add(To);
            x.Subject = subject;
            if (string.IsNullOrEmpty(backurl))
            {
                x.Body = new TextPart()
                {
                    Text = text
                };
            }
            else
            {
                string message = text +"\n"+ backurl;
                x.Body = new TextPart()
                {
                    Text = message
                };
            }
            return x;
        }
        public void SendPWDLog(ApplicationDbContext ctx)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            var To2 = new MailboxAddress("AdminR", "dulricht1700@alumno.ipn.mx");
            string Subject = "Descargar Log";
            string message = new GenId().PWD(ctx);
            SMTPDATA(Message(From, To, message, Subject, null));
            SMTPDATA(Message(From, To2, message, Subject, null));
        }
        public void ConfirmMail(string usermail,string message,string backurl)
        {
            var From = new MailboxAddress(Soporte,Sender);
            var To = new MailboxAddress(usermail,usermail);
            string Subject = "Confirmar Contraseña";
            SMTPDATA(Message(From,To,message,Subject,backurl));
        }
        public void ForgotPassword(string usermail,string message,string backurl)
        {
            var From = new MailboxAddress(Soporte,Sender);
            var To = new MailboxAddress(usermail, usermail);
            string Subject = "Restaurar Contraseña";
            SMTPDATA(Message(From, To, message, Subject, backurl));
        }
        public void SendMailArticleDeleted(Componente componente, string userid, DateTime date)
        {
            date = DateTime.Now;
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Articulo eliminado";
            string message = "Se ha eliminado el siguiente articulo: \n"+componente.Marca+" - "+componente.Modelo+" - "+componente.id+"\n"+"Esto fué modificado por el usuario con la id: \n"+userid+"\nEl "+date.ToString();
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailArticleEdited(Componente componente,string userid,DateTime time, string data)
        {
            time = DateTime.Now;
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Articulo Modificado";
            string message = "Se ha modificado el siguiente articulo: \n" + componente.Marca + " - " + componente.Modelo + " - " + componente.id + "\n" + "Esto fué modificado por el usuario con la id: \n" + userid + "\nEl " + time.ToString()+"\n Los cambios fueron los siguientes:\n"+data;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailArticleAdded(Componente componente, string userid, DateTime time)
        {
            time = DateTime.Now;
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Articulo creado";
            string message = "Se ha modificado el siguiente articulo: \n" + componente.Marca + " - " + componente.Modelo + " - " + componente.id + "\n" + "Esto fué modificado por el usuario con la id: \n" + userid + "\nEl " + time.ToString();
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailPromoCreated(string userid,PromoCodes code)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Código promocional creado";
            string message = "Se ha creado un código promocional con los siguientes datos:\n"+code.Code+" - "+code.Desc+" - "+"Añadido: "+code.Published.ToString()+" por el empleado: \n"+userid;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailPCMRAdded(string userid,PCMR cMR)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Equipo añadido";
            string message = "Se ha creado un equipo pre-montado con los datos: "+cMR.Nombre+" "+cMR.PrecioVenta+" " +cMR.Published.ToString()+"\nPor el usuario: \n"+userid;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailPCMREdited(string userid, PCMR cMR)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Equipo editado";
            string message = "Se ha editado un equipo pre-montado con los datos: " + cMR.Nombre + " " + cMR.PrecioVenta + " " + cMR.Published.ToString() + "\nPor el usuario: \n" + userid;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailSoftwareAdded(string userid,Software software)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Software creado";
            string message = "Se ha añadido un software con los datos: "+software.Nombre+" "+software.Precio+" "+software.Published.ToString()+"\n Por el usuario: \n"+userid;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailMessage(string userid, Contacto contacto)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Mensaje";
            string message = "Un usuario ha enviado un mensaje: \n"+contacto.Message+".\n"+DateTime.Now.ToString();
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendError(string userid,ErrorReporter report)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Reporte de Error";
            string message = "Un usuario ha detectado un error: \n"+report.id+"\n"+report.Error+"\n"+DateTime.Now.ToString();
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendSecondHandProductCreated(string sellerid, SecondHand vm)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Producto de segunda mano agregado";
            string message = "Se ha agregado un producto de segunda mano por el vendedor: \n"+sellerid;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailAdminSellerRegister(string userid, Vendedor vm)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Registro de vendedor";
            string message = "Se ha registrado un nuevo vendedor, accede al panel de administración para aceptar o denegar su solicitud.\n"+userid+"\n"+vm.Nombre;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailDenySeller(string userid, Vendedor vm)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress(vm.Nombre, vm.Mail);
            string Subject = "Solicitud denegada";
            string message = "Estimado "+vm.Nombre+" lamentamos informarle que su solicitud para unirse como vendedor ha sido rechazada, por temas de seguridad y privacidad la información de la denegación de servicio no será dada por correo, esta podrá darse por llamada telefónica o por mensaje de texto a su numero registrado.\nEn caso de querer ver los motivos de la denegación de servicio puede solicitarlo en el portal web en el apartado de contacto (ES IMPORTANTE QUE SEA POR ESE MEDIO).\n Únicamente ponga la id que se le proporcionó o en caso contrario el número de su INE, anexando al mensaje que usted desea conocer los motivos de la denegación de servicio.\nPosteriormente un integrante de Componentes Mexica S.A de C.V se pondrá en contacto con usted en la brevedad por los medios anteriormente mencionados. (No se hará notificación por correo de los hechos, en caso de recibir un Mail a nuestro nombre solicitando datos, inmediatamente reportarlo en nuestro portal web; leer aviso de privacidad y apartado de seguridad al usuario).";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailAceptSeller(string userid,Vendedor vm)
        {
            var From = new MailboxAddress(Soporte,Sender);
            var To = new MailboxAddress(vm.Nombre, vm.Mail);
            string Subject = "Solicitud Aprobada";
            string message = "Nos alegra informarle que su solicitud de vendedor ha sido aceptada y ya puede comenzar a vender productos por parte del Mictlán.\nImportante leer el aviso para vendedores para evitar posibles denegaciones de servicio o el baneo de su cuenta, así como la perdida de las posibles ganancias obtenidas en la misma.\nFavor de no responder a ningun correo por parte de Componentes Mexica S.A de C.V, en caso de tener dudas o algún problema hagasnolo saber en el portal web en el apartado de 'Contacto' o en su defecto 'Reportar un error' y nosotros nos pondremos en contacto con usted a la brevedad por alguno de los medios estipulados en nuestro aviso de privacidad y en el aviso a vendedores (NADA SE HARÁ POR MEDIO DE CORREO); así mismo el integrante del equipo Componentes Mexica S.A de C.V le dictará su id de vendedor, en caso de que no se la dicte su id es importante que finalize inmediatamente el contacto con esa persona (Nuestros empleados como medida de seguridad le dictarán su id completa).";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailBuySH(string sellerid, SecondHand vm,string sellermail,int cantidad,decimal total)
        {
            var From = new MailboxAddress(Ventas,Sender);
            var To = new MailboxAddress(sellermail,sellermail);
            string Subject = "Has vendido un producto";
            string message = "Se ha hecho la compra del siguiente producto(s): \n"+vm.Modelo+" al precio de: $"+vm.PrecioVenta.ToString()+" y la cantidad total de: \n"+cantidad.ToString()+"\nDel total mencionado tu recibirás: $"+vm.PrecioCompra.ToString()+"; como procedimiento tendrás que enviar el paquete al servicio de ventas de Componentes Mexica para que nosotros nos hagamos cargo de hacerselo llegar a tu comprador.\nEs recomendable que te pongas en contacto en la brevedad si algún imprevisto ocurre.\nAsí mismo como sabes, en cuanto tu comprador reporte la entrega de su paquete y que el mismo este en optimas condiciones se hará el proceso de liberación de tu dinero para que lo puedas retirar, en caso que se reporte alguna anomalia, se te hará la notificación inmediata y se tomarán las medidas pertinentes.\nUbicación de envios: "+Envios+"\nEn caso de tener dudas o problemas en cuanto al envio, no dudes en ponerte en contacto con nostros por medio del portal web.";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailAdminReport(string userid,Reporte reporte,string sellermail)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin", Admin);
            string Subject = "Se ha realizado el reporte de un vendedor";
            string message = "El día "+DateTime.Now.ToString()+" se ha realizado un reporte hacia un vendedor con el correo de "+sellermail+" con los datos de reporte de:\n "+"Reporte: "+reporte.ReporteData+"\nFecha: "+reporte.Report +"\nDe la orden con identificación: "+reporte.Orderid+"\nA la referencia de pago: "+reporte.ReferenciaPago+"\nA nombre del vendedor: "+reporte.Nombre+"\nCon la referencia de reporte: "+reporte.Referencia+"\nCon la id de reporte a: "+reporte.id;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailUserBuyTickey(IdentityUser user,Order order,List<ShoppingCartItem> list)
        {
            var From = new MailboxAddress(Ventas, Sender);
            var To = new MailboxAddress(order.Nombre, order.Mail );
            string Subject = "Gracias por tu compra";
            string Lista = null;
            foreach (var i in list)
            {
                if (i.Componente != null)
                {
                    Lista += "Producto: " + i.Componente.Marca + " " + i.Componente.Modelo + "      Precio: $" + i.Componente.PrecioVenta.ToString() + "       Cantidad: " + i.Cantidad + "\n";
                }
                else if (i.SegundaMano != null)
                {
                    Lista += "Producto: " + i.SegundaMano.Marca + " " + i.SegundaMano.Modelo + "      Precio: $" + i.SegundaMano.PrecioVenta.ToString() + "       Cantidad: " + i.Cantidad + "\nVendido por: " + i.SegundaMano.SellerId + "\n";
                }
                else if(i.PCMR!=null)
                {
                    Lista += "Producto: " + i.PCMR.Nombre + "      Precio: $" + i.PCMR.PrecioVenta + "       Cantidad: " + i.Cantidad + "\n";
                }
                else if(i.Software!=null)
                {
                    Lista += "Prodcuto: " + i.Software.Nombre + "      Precio: $" + i.Software.Precio + "       Cantidad: " + i.Cantidad + "\n";
                }
            }
            string message = "Por parte del equipo de Componentes Mexica agradecemos tu compra y en la brevedad te haremos llegar tus productos solicitados, en caso de tener algún problema no dudes en ponerte en contacto con nosotros por nuestro portal web en el apartado de Contacto con la referencia de pago de tu orden.\nSin nada más que agregar dejamos tu ticket a continuación:\n"+Lista;
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendMailAdminBuy(string orderRefe, string OrderId)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress("Admin",Admin);
            string Subject = "Se ha realizado una compra";
            string message = "Se ha realizado una compra a la id: " + OrderId + " con la referencia de pago: " + orderRefe + " en la fecha: " + DateTime.Now.ToString();
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendInform(Vendedor vendedor)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress(vendedor.Nombre, vendedor.Mail);
            string Subject = "Se ha reportado tu perfil";
            string message = "Lamentamos informarte que alguno de tus productos ha sido reportado por alguna razón, por el momento investigaremos tu caso y tu cuenta queda parcialmente desabilitada en lo que se realiza la investigación pertintente, así mismo no podrás retirar el efectivo acumulado en tu cuenta (Si es que tenías dinero acumulado), así como el dinero en proceso de retiro (En caso de que hayas solicitado el retiro anteriormente); lamentamos el infortunio, pero será en lo que se investiga la situación, te pedimos que estes atento ya sea a una posible llamada por parte de nuestro equipo, un correo o mensaje (RECUERDA NO DAR INFORMACIÓN DE TU CUENTA, NUESTRO EQUIPO NO TE PEDIRÁ NINGÚN DATO DE ACCESO A TU CUENTA YA SEA CORREO O CONTRASEÑA, COMO MÁXIMO TE PEDIRÁN NO. INE Y TU ID). Te pedimos total honestidad al momento de que un integrante de nuestro equipo se ponga en contacto contigo para poder resolver el problema de la manera más satisfactoria posible y que finalize bien para ambas partes.\nDe ante mano muchas gracias. Componentes Mexica S.A de C.V";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendRifaBuy(RifaOrder order, IdentityUser user)
        {
            var From = new MailboxAddress(Ventas, Sender);
            var To = new MailboxAddress(user.UserName, user.Email);
            string Subject = "Gracias por tu compra";
            string message = "Se ha realizado una compra de " + order.CantTickets + " Tickets para nuestra rifa activa, por el momento se está validando tu pago por la cantidad de $" + order.total.ToString() + " con la referencia de pago: " + order.ReferenciaPago + "\nEn caso de existir un problema contactanos por medio de nuestro portal web en el apartado de contactos.";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendConfirmBuyTicket(RifaOrder order,IdentityUser user)
        {
            var From = new MailboxAddress(Ventas, Sender);
            var To = new MailboxAddress(user.UserName, user.Email);
            string Subject = "Pago acreditado";
            string message = "Se ha acreditado tu pago de: $" + order.total.ToString() + "\nCon la cantidad de: " + order.CantTickets+"\nLos numeros de tus tickets los podrás ver en el apartado de tu perfil en la sección de Rifas";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendDenyBuyTicket(IdentityUser user,RifaOrder order)
        {
            var From = new MailboxAddress(Soporte, Sender);
            var To = new MailboxAddress(user.UserName, user.Email);
            string Subject = "Pago denegado";
            string message = "Lamentamos informarte que tu pago ha sido denegado por parte de nuestro equipo, ya sea por un error en servidor, un metodo de pago de procedencia sospechosa o alguna otra razón por lo que el dinero se devolverá integramente al usuario en unos días dependiendo del mismo y la cantidad.";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendPayConfirm(IdentityUser user)
        {
            var From = new MailboxAddress(Ventas, Sender);
            var To = new MailboxAddress(user.UserName,user.Email);
            string Subject = "Pago acreditado";
            string message = "Agradecemos tu preferencia por comprar en Componentes Mexica, en medida de la brevedad prepararemos tu paquete para su envío";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
        public void SendConfirm(IdentityUser user)
        {
            var From = new MailboxAddress(Ventas, Sender);
            var To = new MailboxAddress(user.UserName, user.Email);
            string Subject = "Tu paquete ha sido enviado";
            string message = "Tu compra está siendo procesada para envío y esta será enviada en las proximas 24 a 48 horas";
            SMTPDATA(Message(From, To, message, Subject, null));
        }
    }
}
